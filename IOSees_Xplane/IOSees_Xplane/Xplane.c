
#define NAG_CALL __stdcall 
#define NAG_DLL_EXPIMP  __declspec(dllexport)

#include <stdio.h>
#include <string.h>
#include "XPLMProcessing.h"
#include "XPLMDataAccess.h"
#include "XPLMUtilities.h"
#include "XPLMGraphics.h"

#pragma data_seg (".EES")
	
	/* Weather - Visibility */
	float plugin_weather_visibility = 10000;

	/* Position to place plane on start-up */
	double lat = 47.26083333;
	double lon = 11.34722222;
	double alt = 850; //meters above sea level

#pragma data_seg()
#pragma comment(linker, "/section:.EES,rws")


NAG_DLL_EXPIMP void weather_visibility(double in);

float	flight_callback (
                                   float                inElapsedSinceLastCall,    
                                   float                inElapsedTimeSinceLastFlightLoop,    
                                   int                  inCounter,    
                                   void *               inRefcon);

float	weather_callback (
                                   float                inElapsedSinceLastCall,    
                                   float                inElapsedTimeSinceLastFlightLoop,    
                                   int                  inCounter,    
                                   void *               inRefcon);

NAG_DLL_EXPIMP void weather_visibility(float in)
{
	plugin_weather_visibility = in;
}


PLUGIN_API int XPluginStart(
						char *		outName,
						char *		outSig,
						char *		outDesc)
{
	char	outputPath[255];
	strcpy(outName, "TTSL");
	strcpy(outSig, "TTSL.EES.IOS");
	strcpy(outDesc, "Plugin to control environmental elements for EES project");

	// Register move plane
	XPLMRegisterFlightLoopCallback(		
			flight_callback,	/* Callback */
			1.0,					/* Interval */
			NULL);					/* refcon not used. */

	// Register weather
	XPLMRegisterFlightLoopCallback(		
			weather_callback,	/* Callback */
			1.0,					/* Interval */
			NULL);					/* refcon not used. */

	return 1;
}

PLUGIN_API void	XPluginStop(void)
{
	/* Unregister the callback */
	XPLMUnregisterFlightLoopCallback(flight_callback, NULL);
}

PLUGIN_API void XPluginDisable(void)
{
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

float	flight_callback (
                                   float                inElapsedSinceLastCall,    
                                   float                inElapsedTimeSinceLastFlightLoop,    
                                   int                  inCounter,    
                                   void *               inRefcon)
{
	/*double outX, outY, outZ;
	XPLMDataRef		local_x = NULL;
	XPLMDataRef		local_y = NULL;
	XPLMDataRef		local_z = NULL;

	local_x = XPLMFindDataRef("sim/flightmodel/position/local_x");
	local_y = XPLMFindDataRef("sim/flightmodel/position/local_y");
	local_z = XPLMFindDataRef("sim/flightmodel/position/local_z");

	XPLMWorldToLocal(lat, lon, alt, &outX, &outY, &outZ);
	
	XPLMSetDatad(local_x, outX);
	XPLMSetDatad(local_y, outY);
	XPLMSetDatad(local_z, outZ);

	XPLMCommandKeyStroke((XPLMCommandKeyID) xplm_key_pause);*/
	
	return 0;
}   

float	weather_callback (
                                   float                inElapsedSinceLastCall,    
                                   float                inElapsedTimeSinceLastFlightLoop,    
                                   int                  inCounter,    
                                   void *               inRefcon)
{
	XPLMDataRef visible_range;

	visible_range = XPLMFindDataRef("sim/weather/visibility_reported_m");

	XPLMSetDataf(visible_range, plugin_weather_visibility);

	return 1.0;
} 