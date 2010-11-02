/*
 * TimedProcessing.c
 * 
 * This example plugin demonstrates how to use the timed processing callbacks
 * to continuously record sim data to disk.
 * 
 * This technique can be used to record data to disk or to the network.  Unlike
 * UDP data output, we can increase our frequency to capture data every single
 * sim frame.  (This example records once per second.)
 * 
 * Use the timed processing APIs to do any periodic or asynchronous action in
 * your plugin.
 * 
 */

#include <stdio.h>
#include <string.h>
#include "XPLMProcessing.h"
#include "XPLMDataAccess.h"
#include "XPLMUtilities.h"


#pragma data_seg(".EES")

/* File to write data to. */
static FILE *	gOutputFile;

/* Data refs we will record. */
static XPLMDataRef		gPlaneLat;
static XPLMDataRef		gPlaneLon;
static XPLMDataRef		gPlaneEl;
static XPLMDataRef		gPlaneVis;

static float vis_amount;

#pragma data_seg()
#pragma comment(linker, "/section:.EES,rws")


static float	MyFlightLoopCallback(
                                   float                inElapsedSinceLastCall,    
                                   float                inElapsedTimeSinceLastFlightLoop,    
                                   int                  inCounter,    
                                   void *               inRefcon);    


PLUGIN_API int XPluginStart(
						char *		outName,
						char *		outSig,
						char *		outDesc)
{
	char	outputPath[255];
		
	strcpy(outName, "TimedProcessing");
	strcpy(outSig, "xplanesdk.examples.timedprocessing");
	strcpy(outDesc, "A plugin that records sim data.");

	vis_amount = 5000;

	/* Open a file to write to.  We locate the X-System directory 
	 * and then concatenate our file name.  This makes us save in
	 * the X-System directory.  Open the file. */
	XPLMGetSystemPath(outputPath);
	strcat(outputPath, "TimedProcessing.txt");

	
	gOutputFile = fopen(outputPath, "w");

	/* Find the data refs we want to record. */
	gPlaneLat = XPLMFindDataRef("sim/flightmodel/position/latitude");
	gPlaneLon = XPLMFindDataRef("sim/flightmodel/position/longitude");
	gPlaneEl = XPLMFindDataRef("sim/flightmodel/position/elevation");
	gPlaneVis = XPLMFindDataRef("sim/weather/visibility_reported_m");

	/* Register our callback for once a second.  Positive intervals
	 * are in seconds, negative are the negative of sim frames.  Zero
	 * registers but does not schedule a callback for time. */
	XPLMRegisterFlightLoopCallback(		
			MyFlightLoopCallback,	/* Callback */
			1.0,					/* Interval */
			NULL);					/* refcon not used. */
			
	return 1;
}

__declspec( dllexport ) void TestProcess(float amount)
{
	vis_amount = 100;
}

PLUGIN_API void	XPluginStop(void)
{
	/* Unregister the callback */
	XPLMUnregisterFlightLoopCallback(MyFlightLoopCallback, NULL);
	
	/* Close the file */
	fclose(gOutputFile);
}

PLUGIN_API void XPluginDisable(void)
{
	/* Flush the file when we are disabled.  This is convenient; you 
	 * can disable the plugin and then look at the output on disk. */
	fflush(gOutputFile);
}

PLUGIN_API int XPluginEnable(void)
{
	return 1;
}

PLUGIN_API void XPluginReceiveMessage(
					XPLMPluginID	inFromWho,
					long			inMessage,
					void *			inParam)
{
}

float	MyFlightLoopCallback(
                                   float                inElapsedSinceLastCall,    
                                   float                inElapsedTimeSinceLastFlightLoop,    
                                   int                  inCounter,    
                                   void *               inRefcon)
{
	/* The actual callback.  First we read the sim's time and the data. */
	float	elapsed = XPLMGetElapsedTime();
	float	lat = XPLMGetDataf(gPlaneLat);
	float	lon = XPLMGetDataf(gPlaneLon);
	float	el = XPLMGetDataf(gPlaneEl);
	float	vis = XPLMGetDataf(gPlaneVis);
	
	/* Write the data to a file. */
	fprintf(gOutputFile, "Vis=%f,Time=%f,lat=%f,lon=%f,el=%f.\n",vis,elapsed, lat, lon, el);

	XPLMSetDataf(gPlaneVis, vis_amount);
	
	/* Return 1.0 to indicate that we want to be called again in 1 second. */
	return 1.0;
}